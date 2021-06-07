using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMerger.CustomObjects {
    public class DataBaseClass {

        /**
         * forms the foundation of both the monster and modification class. holds the data type and catagory, aswell as the functions to communicate with the info container
         * 
         */


        //datatype: determines the difference between monster and modifications: Monsters are meant to hold base stats, Modifications are meant to modify monsters

        public DataManager.DataType dataType;

        //name: saves the name of the data!

        public string name = "";

        //catagory: holds a custom string that determines which catagory to put the data in, to allow for better sorting

        public string catagory = "";

        //description: holds a short description meant for usage within the program

        public string description = "";

        //infoContainer: holds the actual information

        public InfoContainer infoContainer;


        //contructor:

        public DataBaseClass() {
            //empty constructor for deserialisation only!
        }

        public DataBaseClass(DataManager.DataType dataType) {
            this.dataType=dataType;

            //create empty info container:
            infoContainer = new InfoContainer();
        }

        public DataBaseClass(DataManager.DataType dataType, InfoContainer infoContainer) {
            this.dataType=dataType;
            this.infoContainer = infoContainer;
        }

        public Dictionary<string, Preset> PresetLibary { get; set; } = new Dictionary<string, Preset>();
    }
}
