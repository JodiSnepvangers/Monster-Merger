using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMerger.CustomObjects {

    public class StorageHandler {


        /**
         * 
         * handles the storage and accessibility of data within ram. holds everything by name!
         * 
         */

        //holds the actual data within it
        private Dictionary<string, DataBaseClass> dataBaseMap = new Dictionary<string, DataBaseClass>();



        //takes the database class and puts it in its own libary
        public void SaveData(DataBaseClass input) {
            //retrieve common data from input
            string name = input.name.ToLower();


            //now save data to libary
            //check if data exist. if not, make it:
            if(!dataBaseMap.ContainsKey(name)) {
                //catagory does not exist!
                dataBaseMap.Add(name, input);
            } else {
                //key already exist. overwrite!
                dataBaseMap[name] = input;
            }
        }

        //loads data from this storage. given a name for the data
        public DataBaseClass LoadData(string name) {
            name = name.ToLower(); //removes capitilisation
            if(dataBaseMap.ContainsKey(name)) {
                return dataBaseMap[name];
            }
            return null; //key did not exist. return null!
        }




        //deletes a entry from this libary
        public bool deleteData(string name) {
            name = name.ToLower(); //removes capitilisation
            if(dataBaseMap.ContainsKey(name)) {
                dataBaseMap.Remove(name);
                return true;
            }
            return false;
        }

        

        //prepares and outputs a array of names of the stored data
        public List<string> DataNameList() {
            List<string> output = new List<string>();
            foreach(DataBaseClass dataObject in dataBaseMap.Values) {
                output.Add(dataObject.name);
            }
            return output;
        }


        //prepares and outputs a array of catagory of the stored data
        public List<string> DataCatagoryList() {
            List<string> output = new List<string>(); //is list that gets out putted
            List<string> testList = new List<string>(); //used for checking to ensure catagories do not miss match
            foreach(DataBaseClass dataObject in dataBaseMap.Values) {
                //go though each object, test if their catagory exists in the test list. if not, and their string is not empty, save to output list
                if(!testList.Contains(dataObject.catagory.Replace(" ", "").ToLower()) && dataObject.catagory.ToLower() != "") {
                    output.Add(dataObject.catagory);
                    testList.Add(dataObject.catagory.Replace(" ", "").ToLower());
                }
            }
            return output;
        }


        //prepares and outputs a array of names of the stored data
        //filters based on catagory given
        public List<string> DataNameList(string catagory) {
            List<string> output = new List<string>();
            catagory = catagory.ToLower();
            foreach(DataBaseClass dataObject in dataBaseMap.Values) {
                if(dataObject.catagory.ToLower() == catagory) { 
                    output.Add(dataObject.name);
                }
            }
            return output;
        }


        //checks if a key with the name already exist.
        public bool nameExists(string name) {
            name = name.ToLower();
            return dataBaseMap.ContainsKey(name);
        }
    }
}
