using CCFTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCFTracker.Translators
{
    public class QualificationTranslator
    {
        public CCFTracker.ViewModel.QualificationView QualificationToViewModel(Qualification source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return new ViewModel.QualificationView
            {
                ID = source.ID,
                QualName = $"{source.QualName}",
                PassMark = source.PassMark,
                ParOrChi = $"{source.ParOrChi}",
                Parent = $"{source.Parent}",
                NumChi = source.NumChi,
                MinChiPass = source.MinChiPass
            };
        }
    }
}
