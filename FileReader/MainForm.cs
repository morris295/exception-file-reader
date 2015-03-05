using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader
{
    public partial class MainForm : Form
    {
        private OpenFileDialog _fileDialog = new OpenFileDialog();
        private String _fileContents;
        private double _fileSize;
        private FileInfo _fileInfo;
        private bool _throwArgException;
        private bool _throwPathException;
        private bool _throwDirectoryException;
        private bool _throwIOException;
        private bool _throwUnauthorizedException;
        private bool _throwFileNotfoundException;
        private bool _throwNotSupportedException;
        private bool _throwSecurityException;

        public MainForm()
        {
            _throwArgException = false;
            _throwDirectoryException = false;
            _throwFileNotfoundException = false;
            _throwIOException = false;
            _throwNotSupportedException = false;
            _throwPathException = false;
            _throwSecurityException = false;
            _throwUnauthorizedException = false;
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = _fileDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    if (_throwArgException == true)
                    {
                        throw new ArgumentException();
                    }
                    if (_throwDirectoryException == true)
                    {
                        throw new DirectoryNotFoundException();
                    }
                    if (_throwFileNotfoundException == true)
                    {
                        throw new FileNotFoundException();
                    }
                    if (_throwIOException == true)
                    {
                        throw new IOException();
                    }
                    if (_throwNotSupportedException == true)
                    {
                        throw new NotSupportedException();
                    }
                    if (_throwPathException == true)
                    {
                        throw new PathTooLongException();
                    }
                    if (_throwSecurityException == true)
                    {
                        throw new SecurityException();
                    }
                    if (_throwUnauthorizedException == true)
                    {
                        throw new UnauthorizedAccessException();
                    }

                    _fileContents = File.ReadAllText(_fileDialog.FileName);
                    fileContentsRichTextBox.Text = _fileContents;
                    fileNameToolStripStatusLabel.Text = _fileDialog.SafeFileName;
                    _fileInfo = new FileInfo(_fileDialog.FileName);
                    long fileOpenedSize = _fileInfo.Length;
                    _fileSize = fileOpenedSize / 1024;
                    MessageBox.Show(fileOpenedSize.ToString());
                    fileSizeToolStripStatusLabel.Text = _fileSize.ToString() + " Mb";
                }
                catch (ArgumentException ex)
                {
                    displayException(ex);
                }
                catch (PathTooLongException ex)
                {
                    displayException(ex);
                }
                catch (DirectoryNotFoundException ex)
                {
                    displayException(ex);
                }
                catch (IOException ex)
                {
                    displayException(ex);
                }
                catch (UnauthorizedAccessException ex)
                {
                    displayException(ex);
                }
                catch (NotSupportedException ex)
                {
                    displayException(ex);
                }
                catch (SecurityException ex)
                {
                    displayException(ex);
                }
                catch (Exception ex)
                {
                    displayException(ex);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentsRichTextBox.Text = "";
            fileNameToolStripStatusLabel.Text = "";
        }

        private void displayException(Exception e)
        {
            String type = e.GetType().ToString();
            MessageBox.Show("Exception: " + type + " thrown.");
            Console.WriteLine(e.StackTrace.ToString());
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwArgException = false;
            _throwDirectoryException = false;
            _throwFileNotfoundException = false;
            _throwIOException = false;
            _throwNotSupportedException = false;
            _throwPathException = false;
            _throwSecurityException = false;
            _throwUnauthorizedException = false;
        }

        private void argumentExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwArgException = true;
        }

        private void pathTooLongExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwPathException = true;
        }

        private void directoryNotFoundExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwDirectoryException = true;
        }

        private void iOExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwIOException = true;
        }

        private void unauthorizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwUnauthorizedException = true;
        }

        private void fileNotFoundExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwFileNotfoundException = true;
        }

        private void notSupportedExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwNotSupportedException = true;
        }

        private void securityExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _throwSecurityException = true;
        }
    }
}
