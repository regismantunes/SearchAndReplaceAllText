using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace RA.SearchAndReplaceAllText
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void rbtnFile_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchFile.Enabled = rbtnFile.Checked;
            btnSearchFile.Enabled = rbtnFile.Checked;
            txtSearchDirectory.Enabled = !rbtnFile.Checked;
            btnSearchDirectory.Enabled = !rbtnFile.Checked;
            txtSearchFilter.Enabled = !rbtnFile.Checked;
            chkSubdiretories.Enabled = !rbtnFile.Checked;
            lblFilter.Enabled = !rbtnFile.Checked;
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                FileName = txtSearchFile.Text
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                txtSearchFile.Text = ofd.FileName;
        }

        private void btnSearchDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                SelectedPath = txtSearchDirectory.Text
            };

            if (fbd.ShowDialog() == DialogResult.OK)
                txtSearchDirectory.Text = fbd.SelectedPath;
        }

        private string[] _files;
        private int _iFiles = -1;
        
        private string[] GetFiles()
        {
            List<string> filesToReturn = new List<string>();
            try
            {
                if (rbtnFile.Checked)
                {
                    if (File.Exists(txtSearchFile.Text))
                        filesToReturn.Add(txtSearchFile.Text);
                    else
                        throw new FileNotFoundException("The file was not found.");
                }
                else
                {
                    if (Directory.Exists(txtSearchDirectory.Text))
                    {
                        bool caseSensitive = chkCaseSensitive.Checked;
                        string texto = !caseSensitive ? txtFind.Text.ToUpper() : txtFind.Text;

                        SearchInDirectory(txtSearchDirectory.Text, txtSearchFilter.Text, chkSubdiretories.Checked, chkFileDirectoriesNames.Checked, texto, caseSensitive, filesToReturn);
                    }
                    else
                        throw new DirectoryNotFoundException("The directory was not found.");
                }
            }
            catch (ThreadAbortException)
            {
                WriteLog("The search was stopped by user.");
            }
            catch
            {
                throw;
            }
            
            return filesToReturn.ToArray();
        }

        private void SearchInDirectory(string directorySearch, string searchFilter, bool searchInSubdiretories, bool searchInNames, string textSearch, bool caseSensitive, List<string> filesToReturn)
        {
            try
            {
                string[] auxFiles = Directory.GetFiles(directorySearch, searchFilter, SearchOption.TopDirectoryOnly);
                foreach (string fileToSeach in auxFiles)
                {
                    try
                    {
                        string stringToSearch = searchInNames
                            ? new FileInfo(fileToSeach).Name
                            : File.ReadAllText(fileToSeach);

                        if (!caseSensitive)
                            stringToSearch = stringToSearch.ToUpperInvariant();

                        if (stringToSearch.Contains(textSearch))
                            filesToReturn.Add(fileToSeach);
                    }
                    catch (Exception ex)
                    {
                        WriteLog($"Could not verify the file {fileToSeach}. Error: {ex.Message}");
                    }
                }

                if (searchInSubdiretories)
                {
                    string[] auxDirectories = Directory.GetDirectories(directorySearch);
                    foreach (string directoryToSearch in auxDirectories)
                        SearchInDirectory(directoryToSearch, searchFilter, searchInSubdiretories, searchInNames, textSearch, caseSensitive, filesToReturn);
                }
            }
            catch (UnauthorizedAccessException)
            {
                WriteLog($"There is no permission to ready the directory {directorySearch}");
            }
            catch (ThreadAbortException)
            {
                throw;
            }
            catch (Exception ex)
            {
                WriteLog($"An exception occurred while finding in {directorySearch}. {ex.Message}");
            }
        }

        private void WriteLog(string texto)
        {
            txtMessages.Text = $"{texto}\r\n{txtMessages.Text}";
            Application.DoEvents();
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                MyMessage.ShowError("Find text cannot be empty.");
                txtFind.Focus();
            }
            else
            {
                startThreadSearch(() =>
                {
                    try
                    {
                        _iFiles = -1;
                        _files = GetFiles();
                        for (int i = _files.Length; i > 0; i--)
                            WriteLog(i.ToString() + " - " + _files[i - 1]);
                        WriteLog($"{_files.Length} files found.");

                        txtPreview.Text = string.Empty;

                    }
                    catch (ThreadAbortException) { }
                    catch (Exception ex)
                    {
                        MyMessage.ShowError(ex.Message);
                    }
                });
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            string textToFind = txtFind.Text;
            if (string.IsNullOrEmpty(textToFind))
            {
                MyMessage.ShowError("Find text cannot be empty.");
                txtFind.Focus();
            }
            else
            {
                startThreadSearch(() =>
                {
                    try
                    {
                        if (_files.Length == 0)
                        {
                            _iFiles = -1;
                            _files = GetFiles();
                            txtPreview.Text = string.Empty;
                        }

                        if (_files.Length == 0)
                            MyMessage.ShowError("No files found.");
                        else
                        {
                            _iFiles++;
                            if (_iFiles > _files.Length - 1)
                            {
                                MyMessage.ShowInformation("No more files in the list.");
                                txtPreview.Text = string.Empty;
                            }
                            else
                            {
                                if (chkFileDirectoriesNames.Checked)
                                    WriteLog($"File found: {_files[_iFiles]}");
                                else
                                {
                                    txtPreview.Text = File.ReadAllText(_files[_iFiles]);
                                    WriteLog($"Reading {_files[_iFiles]}");

                                    string textToSearch;
                                    if (!chkCaseSensitive.Checked)
                                    {
                                        textToFind = textToFind.ToUpper();
                                        textToSearch = txtPreview.Text.ToUpper();
                                    }
                                    else
                                        textToSearch = txtPreview.Text;

                                    Regex r = new Regex(textToFind);
                                    WriteLog($"{r.Matches(textToSearch).Count} incidences");
                                }
                            }
                        }
                    }
                    catch (ThreadAbortException) { }
                    catch (Exception ex)
                    {
                        MyMessage.ShowError(ex.Message);
                    }
                });
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (_iFiles == -1
                || _iFiles >= _files.Length)
                MyMessage.ShowError("Ther is no current file.");
            else
            {
                if (!chkFileDirectoriesNames.Checked)
                {
                    Encoding encoding = DetectEncoding.GetEncoding(_files[_iFiles]);
                    File.WriteAllText(_files[_iFiles], txtPreview.Text.Replace(txtFind.Text, txtReplace.Text), encoding);
                }
                else
                { 
                    FileInfo auxFile = new FileInfo(_files[_iFiles]);
                    auxFile.MoveTo($"{auxFile.DirectoryName}\\{auxFile.Name.Replace(txtFind.Text, txtReplace.Text)}");
                }
                
                this.btnFindNext_Click(sender, e);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                MyMessage.ShowError("Find text cannot be empty.");
                txtFind.Focus();
            }
            else
            {
                startThreadSearch(() =>
                    {
                        try
                        {
                            if (_iFiles == -1
                                || _iFiles >= _files.Length)
                            {
                                _iFiles = -1;
                                _files = GetFiles();
                            }

                            if (_files.Length == 0)
                                MyMessage.ShowError("No files found.");
                            else
                            {
                                if (!chkFileDirectoriesNames.Checked)
                                {
                                    StringBuilder auxTexto = new StringBuilder();
                                    Regex r;

                                    for (_iFiles++; _iFiles < _files.Length; _iFiles++)
                                    {
                                        auxTexto.Append(File.ReadAllText(_files[_iFiles]));

                                        WriteLog($"Replacing {_iFiles + 1} of {_files.Length} - {_files[_iFiles]}");

                                        try
                                        {
                                            r = new Regex(txtFind.Text);
                                            WriteLog($"{r.Matches(auxTexto.ToString()).Count} incidences");
                                        }
                                        catch { }

                                        auxTexto.Replace(txtFind.Text, txtReplace.Text);

                                        Encoding encoding = DetectEncoding.GetEncoding(_files[_iFiles]);
                                        File.WriteAllText(_files[_iFiles], auxTexto.ToString(), encoding);

                                        auxTexto.Remove(0, auxTexto.Length);
                                    }
                                }
                                else
                                {
                                    for (_iFiles++; _iFiles < _files.Length; _iFiles++)
                                    {
                                        WriteLog($"Replacing {_iFiles + 1} of {_files.Length} - {_files[_iFiles]}");

                                        FileInfo auxFile = new FileInfo(_files[_iFiles]);
                                        auxFile.MoveTo($"{auxFile.DirectoryName}\\{auxFile.Name.Replace(txtFind.Text, txtReplace.Text)}");
                                    }
                                }
                            }
                        }
                        catch (ThreadAbortException) { }
                        catch (Exception ex)
                        {
                            MyMessage.ShowError(ex.Message);
                        }
                    });
            }
        }

        private Thread _tSearch = null;

        private void btnStopSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_tSearch != null)
                    _tSearch.Abort();
            }
            catch (Exception ex)
            {
                MyMessage.ShowError(ex.Message);
            }
        }

        private void startThreadSearch(ThreadStart task)
        {
            _tSearch = new Thread(() =>
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;

                        btnFindAll.Enabled = false;
                        btnFindNext.Enabled = false;
                        btnReplace.Enabled = false;
                        btnReplaceAll.Enabled = false;
                        txtFind.Enabled = false;
                        txtReplace.Enabled = false;
                        gbSearchIn.Enabled = false;
                        chkCaseSensitive.Enabled = false;
                        btnStopSearch.Enabled = true;

                        task.DynamicInvoke(null);
                    }
                    finally
                    {
                        btnFindAll.Enabled = true;
                        btnFindNext.Enabled = true;
                        btnReplace.Enabled = true;
                        btnReplaceAll.Enabled = true;
                        txtFind.Enabled = true;
                        txtReplace.Enabled = true;
                        gbSearchIn.Enabled = true;
                        chkCaseSensitive.Enabled = true;
                        btnStopSearch.Enabled = false;

                        this.Cursor = Cursors.Default;
                    }
                });
            _tSearch.Start();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            rbtnFile_CheckedChanged(sender, e);
        }

        private void deleteSearch()
        {
            _iFiles = -1;
            _files = new string[0];
            txtPreview.Text = string.Empty;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            deleteSearch();
        }

        private void chkCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            deleteSearch();
        }
    }
}
