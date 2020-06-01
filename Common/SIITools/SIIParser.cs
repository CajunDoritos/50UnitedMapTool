using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _50UnitedMapTool.Common.SIITools
{
    class SIIParser
    {

        //Tokens in an SII file
        public static readonly string[] tokens = { "{", "}", ":", "\"" };

        public static string parseSIIToJSONString(string sii)
        {
            string isloated = sii;

            string JSON = null;

            //Break up SII lines by carrige return
            string[] siiLines = isloated.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None);

            for(int i = 0; i < isloated.Length; i++)
            {
                string newJSON = parseLineToJSONLine(siiLines[i]);
                JSON += newJSON;
            }

            return JSON;

        }

        private static string parseLineToJSONLine(string line)
        {
            string JSON = null;

            List<int> tokenPositions = new List<int>();
            int tokensCount = 0;

            //Check each char in line for a token
            for (int i = 0; i < line.Length; i++)
            {
                string c = new string(line[i], 1);

                if(tokens.Contains(c))
                {
                    tokenPositions.Add(i);
                    tokensCount++;
                }
            }

            //If tokens in line do logic
            if(tokensCount > 0)
            {

                List<string> splitLines = new List<string>();

                //Use regex to find all strings that arent tokens
                MatchCollection matches = Regex.Matches(line, "\babc\b");

                foreach(string m in matches)
                {
                    Console.WriteLine(m);
                    splitLines.Add(m);
                }

                //Remove all whitespace from non token strings
                for (int i = 0; i < splitLines.Count; i++)
                {
                    Regex.Replace(splitLines[i], @"\s+", "");
                }

                int pos = 0;
                bool quoteOpen = false;

                //For loop for all tokens in line
                for (int i = 0; i < tokensCount; i++)
                {
                    int currentTokenPosition = tokenPositions[i];

                    //Grab token using list of token positions
                    string token = new string(line[currentTokenPosition], 1);

                    Console.WriteLine(token);

                    if(currentTokenPosition != pos)
                    {
                        JSON += "\"" + splitLines[i] + "\"";
                        pos += splitLines[i].Length;
                    }

                    if (token == tokens[0]) // {
                    {
                        JSON += ":" + tokens[0];
                    }
                    else if (token == tokens[1]) // }
                    {
                        JSON += tokens[1] + ",";
                    }
                    else if (token == tokens[2]) // :
                    {
                        JSON += tokens[2];
                    }
                    else if (token == tokens[3]) // "
                    {
                        if(!quoteOpen)
                        {
                            JSON += "\"" + splitLines[i] + "\"";
                        } else
                        {
                            quoteOpen = false;
                        }
                    }
                    pos++;
                }

                return JSON;

            } else
            {
                return null;
            }
        }

    }
}
