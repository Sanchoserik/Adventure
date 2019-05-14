using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.LocalisationScripts
{
    class GetItemsLocalisation
    {
        private void Start()
        {
            LocaliseComponents lsc = new LocaliseComponents();
            lsc.localiseItems(LoadLocalisation.itemsLocalisationData);
        }
    }
}
