using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRGtaak
{
    class FileHandler
    {
        #region Fields
        StreamReader reader;
        StreamWriter writer;
        FileStream stream;
        string filePathPrime;
        #endregion

        #region Constructors
        public FileHandler(string filePath = "default.txt")
        {
            this.filePathPrime = filePath;
        }

        public FileHandler()
        {

        }
        #endregion

        #region methods

        public List<string> ReadData(string filePath)
        {
            List<string> data = new List<string>();
            try
            {
                stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);

                while (!reader.EndOfStream)
                {
                    data.Add(reader.ReadLine());
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Directory Not Found");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }
            finally
            {
                reader.Close();
                stream.Close();
            }

            return data;
        }



        public void WriteData(List<ItemClass> data, string fileName, bool isAppend)
        {
            try
            {
                if (isAppend)
                    stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                else
                    stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);
                foreach (var s in data)
                {
                    
                    writer.WriteLine("\n");
                    writer.Write(s + ",");
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Directory Not Found");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }

            finally
            {
                writer.Close();
                stream.Close();
            }
        }

        //public void NewCash(string Name, string Password)
        //{

        //    string filename = Name + ".txt";
        //    //string filepath = Path.Combine(Environment.CurrentDirectory, @"\Data\LGData\", filename);
        //    string SecurePass = StringCipher.Encrypt(Password, Name);

        //    try
        //    {
        //        stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
        //        writer = new StreamWriter(stream);

        //        writer.Write(SecurePass);
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        System.Windows.Forms.MessageBox.Show("File Not Found");
        //    }
        //    catch (DirectoryNotFoundException)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Directory Not Found");
        //    }
        //    catch (IOException)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Error");
        //    }

        //    finally
        //    {
        //        writer.Close();
        //        stream.Close();
        //    }
        //}

        //List<string> info = new List<string>();
        //bool isTrue = false;
        //public bool LoginAttempt(string UserNameP, string PassP)
        //{

        //    info = ReadData("Tlogin.txt");
        //    foreach (var item in info)
        //    {

        //        try
        //        {
        //            string FileP = UserNameP + ".txt";
        //            stream = new FileStream(FileP, FileMode.Open, FileAccess.Read);
        //            reader = new StreamReader(stream);
        //            string SecPass = reader.ReadLine();
        //            string decPass = StringCipher.Decrypt(SecPass, UserNameP);
        //            if (PassP == decPass)
        //            {
        //                isTrue = true;
        //            }
        //            else
        //            {
        //                isTrue = false;

        //                // System.Windows.Forms.MessageBox.Show("Your Password Was Incorect","Warnig",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
        //            }
        //        }
        //        catch (FileNotFoundException)
        //        {

        //            System.Windows.Forms.MessageBox.Show("Your Username does not Exist. Please ask a supervisor to make a Account for you");
        //            break;
        //        }


        //    }
        //    return isTrue;
        //}

        #endregion
    }
}
