using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        //get random number
        //create array of strings

        public string getResponse()
        {
            string[] responses = { "Freedom's just another word for nothing left to lose.", "Ask the cutie before you touch the booty.", "I like pie.", "Colonisation is violence."};
            //get random number object
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length);
            return responses[num];
        }
    }
}