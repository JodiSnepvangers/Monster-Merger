using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MonsterMerger.CustomObjects;
using MonsterMerger.UserInterface;

namespace MonsterMerger {
    static class Program {

        public static DataManager dataManager;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create a data manager. data manager may open its own form as a means of adding a progress bar!
            dataManager = new DataManager();

            //CreateTestData(200);

            //display main menu
            Application.Run(new UserInterface.MainMenu());

            //Console.ReadKey();

            //application closing. save all data:
            dataManager.SaveAllData();
        }
        
        public static void WriteError(string input) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.White;

        }

        private static void CreateTestData(int amount) {
            string[] wordList = { "Fairy", "Apple", "Cube", "Portal", "Random", "Crown", "Chess", "Sink", "Dress", "Brush", "Poppycock", "Daddy", "Dawn", "Flurry" };
            Random random = new Random();
            for(int i = 0; i < amount; i++) {
                DataBaseClass dataObj;
                if(random.Next(2) == 1) {
                    dataObj = new DataBaseClass(DataManager.DataType.Monsters);

                } else {
                    dataObj = new DataBaseClass(DataManager.DataType.Modifications);

                }

                dataObj.infoContainer.MainStatBody = random.Next(9) - 2;
                dataObj.infoContainer.MainStatConviction = random.Next(9) - 2;
                dataObj.infoContainer.MainStatCunning = random.Next(9) - 2;
                dataObj.infoContainer.MainStatPassion = random.Next(9) - 2;
                dataObj.infoContainer.MainStatReason = random.Next(9) - 2;
                dataObj.infoContainer.MainStatProwess = random.Next(9) - 2;

                dataObj.infoContainer.SkillAthletics = random.Next(4) + 1;
                dataObj.infoContainer.SkillAuthority = random.Next(4) + 1;
                dataObj.infoContainer.SkillLogic = random.Next(4) + 1;
                dataObj.infoContainer.SkillPanache = random.Next(4) + 1;
                dataObj.infoContainer.SkillPerception = random.Next(4) + 1;
                dataObj.infoContainer.SkillResolve = random.Next(4) + 1;

                dataObj.infoContainer.SkillCrafts = random.Next(5);
                dataObj.infoContainer.SkillKeening = random.Next(5);
                dataObj.infoContainer.SkillKnowledge = random.Next(5);
                dataObj.infoContainer.SkillMedicine = random.Next(5);
                dataObj.infoContainer.SkillStealth = random.Next(5);
                dataObj.infoContainer.SkillSurvival = random.Next(5);

                dataObj.infoContainer.SkillArchery = random.Next(5);
                dataObj.infoContainer.SkillFight = random.Next(5);
                dataObj.infoContainer.SkillMarksmanship = random.Next(5);
                dataObj.infoContainer.SkillMelee = random.Next(5);

                dataObj.name = wordList[random.Next(14)] + wordList[random.Next(14)] + wordList[random.Next(14)];
                dataManager.Save(dataObj);
            }
        }
    }


    
        
}
