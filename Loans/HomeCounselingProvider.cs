using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class HomeCounselingProvider
    {
        public bool? SelectedIndicator { get; set; }
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyAddressCity { get; set; }
        public string AgencyAddressState { get; set; }
        public string AgencyAddressPostalCode { get; set; }
        public string AgencyPhoneDirect { get; set; }
        public string AgencyPhoneTollFree { get; set; }
        public string AgencyFax { get; set; }
        public string AgencyEmail { get; set; }
        public string AgencyWebAddress { get; set; }
        public string LanguagesSupported { get; set; }
        public string CounselingServicesProvided { get; set; }
        public bool? AgencyAffiliationIndicator { get; set; }
        public string AgencyAffiliationDescription { get; set; }
        public string AgencySource { get; set; }
        public decimal? DistanceMiles { get; set; }
        public string AgencyId { get; set; }
        public string Id { get; set; }
        public int? HomeCounselingProviderIndex { get; set; }
        public string HomeCounselingProviderId { get; set; }
    }
}