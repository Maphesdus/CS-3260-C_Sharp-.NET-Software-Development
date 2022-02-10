//Project Prolog
//Name:  Brock Ayres
//Project:  Lab Employee Project
//Class:  CS 3260 C#
//Date: Fall Semester
//Purpose: World Wide Wombat Employee thinger.
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab03EmployeeGui
{
    /// <summary>
    /// Does the actual file manipulation.  Allows reading and saving of files.
    /// </summary>
    public class FileIO : IFileAccess
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private FileIO()
        {
            //istantiate Employee means making it have a value
            //employees = new List<Employee>();

            //****** CODE FOR LAB sORTEDdICTIONARY
            EmployeeDB = new SortedDictionary<uint, Employee>();  //uint is the key, and the value assigned to the key is the Employee
        }

        //Also part of the singleton pattern. Main points from this being part of the singleton pattern: it is a FileIO instance and it is private.
        private static FileIO instance; //needs to be static because it is our instance - is our backing field

        /// <summary>
        /// Accessor to the Business Rules instance
        /// </summary>
        public static FileIO Instance //property
        { //default get and set do automatic backing fields, since here won't use default have to do own backing fields

            get //creates it if it doesn't exist and then returns the backing field
            {
                if (instance == null)
                {
                    instance = new FileIO();
                }
                return instance;
            }
            //set; - DON'T NEED because no one is allowed to replace the BusinessRules instance
        }


        public SortedDictionary<uint, Employee> EmployeeDB
        {
            get;

            set;
        }

        public SortedDictionary<uint, Employee> RemovedEmployeeDB
        {
            get;

            set;
        }

        /// <summary>
        /// NOT USING: implement this functionality in other method.
        /// </summary>
        public void CloseFileDB()
        {
            Console.WriteLine("Attempted to use CloseFileDB, use one of the methods that actually works please :)");
        }

        /// <summary>
        /// NOT USING: implement this functionality in other method.
        /// </summary>
        public void OpenFileDB()
        {
            Console.WriteLine("Attempted to use OpenFileDB, use one of the methods that actually works please :)");
        }

        /// <summary>
        /// Pops up OpenFileDialog box, if correct choice is made then it reads the info out of it.
        /// And puts the result inside of the EmployeeDB
        /// </summary>
        /// <returns>Whether the reading of it was successful.</returns>
        public bool ReadFileDB()
        {
            OpenFileDialog dialogBoxForReadFile = new OpenFileDialog(); //creates new OpenFileDialog box

            dialogBoxForReadFile.InitialDirectory = Environment.SpecialFolder.Personal.ToString();
            //dialogBoxForReadFile.Filter = "employee database files (*.dat) |*.dat | All Files (*.*) |*.*";

            if (dialogBoxForReadFile.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bin = new BinaryFormatter();

                Stream reader = dialogBoxForReadFile.OpenFile();

                try
                {
                    EmployeeDB = (SortedDictionary<uint, Employee>)bin.Deserialize(reader);
                    RemovedEmployeeDB = (SortedDictionary<uint, Employee>)bin.Deserialize(reader);
                }
                catch(System.Security.SecurityException)
                {
                    MessageBox.Show("Don't have file permissions");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failure to read file");
                    return false;
                }   

                finally
                {
                    reader.Close();
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Creates initial directory for where to save files.
        /// Makes sure that a good file is chosen.
        /// Opens file that was selected by the user.
        /// Takes all the info from EmployeeDB and writes it to the file in a serialized form.
        /// </summary>
        public void WriteFileDB()
        {
            SaveFileDialog dialogBoxForOpenFile = new SaveFileDialog();

            dialogBoxForOpenFile.InitialDirectory = Environment.SpecialFolder.Personal.ToString();
            //dialogBoxForOpenFile.Filter = "employee database files (*.dat) | *dat | All Files (*.*) | *.*";

            if (dialogBoxForOpenFile.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bin = new BinaryFormatter();

                Stream writer = dialogBoxForOpenFile.OpenFile();
                bin.Serialize(writer, EmployeeDB);  //Takes all the info from EmployeeDB and writes it to the file in a serialized form.
                bin.Serialize(writer, RemovedEmployeeDB);
                writer.Close();
            }
        }
    }
}
