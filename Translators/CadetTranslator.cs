using CCFTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCFTracker.Translators
{
    public class CadetTranslator
    {
        public CCFTracker.ViewModel.CadetView CadetToViewModel(Cadet source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return new ViewModel.CadetView
            {
                ID = source.ID,
                Rank = $"{source.Rank}",
                FullName = $"{source.Surname} ', ' {source.KnownAs}",
                Year = source.Year,
                Gender = $"{source.Gender}",
                Form = $"{source.Form}",
                GroupLocation = $"{source.Platoon} ', ' {source.Section}"
            };
        }
    }
}
