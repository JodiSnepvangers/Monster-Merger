using MonsterMerger.CustomObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMerger {
    public class DataManager {
        /**
         * handles data loading and saving to disk. provides the data with functions!~
         */
         
        //determines the types of data to be loaded:
        public enum DataType {
            Monsters,
            Modifications
        }

        //holds a array of data for each DataType! strign key is the name!
        Dictionary<DataType, StorageHandler> dataArrays = new Dictionary<DataType, StorageHandler>();



        public DataManager() {
            CreateFolders();
            PrepareDataArrays();
            LoadAllData();
        }


        //creates folders for all datatypes
        private void CreateFolders() {
            string folderName = @".\Data";
            foreach(string subFolderName in Enum.GetNames(typeof(DataType))) {
                string pathString = System.IO.Path.Combine(folderName, subFolderName);
                System.IO.Directory.CreateDirectory(pathString);
            }
        }


        //prepares the arrays to be loaded with data:
        private void PrepareDataArrays() {
            //loop though each data type:
            foreach(DataType currentType in Enum.GetValues(typeof(DataType))) {

                //load default for all data types:
                dataArrays.Add(currentType, new StorageHandler());
            }
        }


        //load data from disk
        public void LoadAllData() {
            //cycle though each file type, find a folder for each
            foreach(DataType currentType in Enum.GetValues(typeof(DataType))) {
                if(Directory.Exists(@".\Data\" + currentType.ToString()) == false) continue; //folder does not exist! skip!
                string[] fileList = Directory.GetFiles(@".\Data\" + currentType.ToString(), "*.json");
                //loop though each file in the current selected folder
                foreach(String currentFile in fileList) {
                    try {
                        DataBaseClass retrievedClass = JsonConvert.DeserializeObject<DataBaseClass>(File.ReadAllText(currentFile));
                        //save data to database!
                        Save(retrievedClass);
                        Console.WriteLine("file loaded: " + currentFile);
                    } catch (JsonSerializationException) {
                        Program.WriteError("file failed: " + currentFile);
                    }
                }
            }
        }



        //saves all current stored data to disk
        public void SaveAllData() {
            foreach(DataType currentType in Enum.GetValues(typeof(DataType))) {
                string currentDirectory = @".\Data\" + currentType.ToString();
                if(Directory.Exists(currentDirectory) == false) {
                    Directory.CreateDirectory(currentDirectory);
                } else {
                    NukeAllData(currentDirectory);
                }
                //loop though each file in the current selected folder
                foreach(string currentName in GetNameList(currentType)) {
                    DataBaseClass currentFile = Load(currentName, currentType);
                    string jsonOut = JsonConvert.SerializeObject(currentFile, Formatting.Indented);
                    File.WriteAllText(currentDirectory + @"\" + currentFile.name + ".json", jsonOut);
                }
            }
        }

        //BE CAREFUL! erases all Json files in a given directory
        public void NukeAllData(string directory) {
            if(Directory.Exists(directory) == false) return; //no directory to erase
            //directory exists! erasing
            foreach(string filePath in Directory.GetFiles(directory, "*.json")) {
                File.Delete(filePath);
            }
        }


        /**
         * 
         * Functions to interface with the database:
         * 
         */

        //saves a object to the database!
        public void Save(DataBaseClass inputObj) {
            if(inputObj.name == "") return;
            GetStorage(inputObj.dataType).SaveData(inputObj);
        }


        //retrieves a object from the selected database!

        public DataBaseClass Load(string name, DataType dataType) {
            return GetStorage(dataType).LoadData(name); ;
        }


        //retrieves a list of names for any particuliar data type
        public List<string> GetNameList(DataType dataType) {
            return GetStorage(dataType).DataNameList();
        }

        //retrieves a list of catagories for any particulair data type
        public List<string> GetCatagoryList(DataType dataType) {
            return GetStorage(dataType).DataCatagoryList();
        }


        //retrieves a list of names for any particulair data type, filtered by catagory
        public List<string> GetNameList(string catagory, DataType dataType) {
            return GetStorage(dataType).DataNameList(catagory);
        }


        //gets the database directly and outputs it for direct control.
        public StorageHandler GetStorage(DataType dataType) {
            return dataArrays[dataType];
        }

        //checks weither a name exists in a given datatype
        public bool NameExists(string name, DataType dataType) {
            return dataArrays[dataType].nameExists(name);
        }

        //delete object from memory
        public bool Delete(DataBaseClass data) {
            bool output =  dataArrays[data.dataType].deleteData(data.name);
            //delete file on filesystem
            /** perhaps there is a better way
            string path = @".\Data\" + data.dataType + @"\" + data.name + ".json";
            if(File.Exists(path)){
                File.Delete(path);
            }*/
            return output;
        }
    }
}
