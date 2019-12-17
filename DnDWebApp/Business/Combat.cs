using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Business
{
    public class Combat
    {
        public double Attack()
        {
            string featureList = "Extra Attack, Some Other Feaure, Something Else Entirely, Action Surge (two uses)"; // TODO  = ExtractLevels.ExtractFeatures
            int actionSurge = featureList.IndexOf("Action Surge (one use)");
            if (actionSurge == -1) // If featureList does not contain one use
            {
                actionSurge = 0;
            }
            else if ((actionSurge = featureList.IndexOf("Action Surge (two use)")) != -1) // If featureList contains two uses (requires one use)
            {
                actionSurge = 2;
            }
            else
            {
                actionSurge = 1;
            }
            return 0;
        }
    }
}
