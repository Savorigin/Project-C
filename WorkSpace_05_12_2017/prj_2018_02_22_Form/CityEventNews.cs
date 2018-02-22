using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_22_Form
{
    class CityEventNews
    {
        public event Action<News> media;
        public void OnUpdate(News news)
        {
            if (media != null) media(news);
        }
    }
}
