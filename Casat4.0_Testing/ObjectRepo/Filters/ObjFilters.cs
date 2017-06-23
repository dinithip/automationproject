using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Filters
{
    class ObjFilters
    {
        private Manager _manager;

        public ObjFilters(Manager m)
        {
            _manager = m;
        }

        public Element casatfilterMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // CASAT User Table Filters

        public Element userfilterbutton { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element idfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[2]/input"); } }

        public Element usernamefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element fisrtnamefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[4]/input"); } }

        public Element lastnamefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[5]/input"); } }

        public Element emailfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[6]/input"); } }

        public Element phonefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[7]/input"); } }

        public Element statusfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[8]/select"); } }

        // DI User Table Filters

        public Element difilterbutton { get { return _manager.ActiveBrowser.Find.ById("saveDi"); } }

        public Element opridfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[2]/input"); } }

        public Element difistnamefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[4]/input"); } }

        public Element dilastnamefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[5]/input"); } }

        public Element diemailfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[6]/input"); } }

        public Element diphonefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[7]/input"); } }

        public Element distatusfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[8]/select"); } }

        // Article Table Filters

        public Element articlefilterbutton { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[3]/button"); } }

        public Element articleidfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[2]/input"); } }

        public Element articlenumberfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[3]/input"); } }

        public Element articlenamefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[4]/input"); } }

        public Element articletypefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[5]/select"); } }

        public Element articleamountfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[6]/input"); } }

        public Element articlefromcofilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[7]/input"); } }

        public Element articletocofilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[8]/input"); } }


        // Article's Article Usage Group Table Filters

        public Element augidfilter{ get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[2]/input"); } }

        public Element augnumberfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[3]/input"); } }

        public Element augnamefilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[4]/input"); } }

        public Element augamountfilter { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[5]/input"); } }


    }
}
