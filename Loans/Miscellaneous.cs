using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Miscellaneous
    {
        public int? MonthsToExclude { get; set; }
        public decimal? PointsPaid { get; set; }
        public decimal? RefundOrOverpaidInterest { get; set; }
        public string BorrowerDescription1 { get; set; }
        public string BorrowerDescription2 { get; set; }
        public string BorrowerDescription3 { get; set; }
        public string TaxId { get; set; }
        public decimal? OtherPresentHousingExpense { get; set; }
        public string SchoolTaxExcluded { get; set; }
        public string FloodInsuranceExcluded { get; set; }
        public string Line1006Excluded { get; set; }
        public string Line1007Excluded { get; set; }
        public string Line1008Excluded { get; set; }
        public string Line1010Excluded { get; set; }
        public string PartnerName { get; set; }
        public string PartnerPhone { get; set; }
        public string PartnerEmail { get; set; }
        public string StatusUrl { get; set; }
        public DateTime? SubmitDate { get; set; }
        public decimal? HousingExpenseIntRate1 { get; set; }
        public decimal? HousingExpenseIntRate2 { get; set; }
        public decimal? HousingExpenseLoanAmt1 { get; set; }
        public decimal? HousingExpenseLoanAmt2 { get; set; }
        public decimal? HousingExpensePayment1 { get; set; }
        public decimal? HousingExpensePayment2 { get; set; }
        public int? FactorForRevolvingDebt { get; set; }
        public int? HousingExpenseTerm1 { get; set; }
        public int? HousingExpenseTerm2 { get; set; }
        public string UseRegZMi { get; set; }
        public string UseGfeTax { get; set; }
        public string OptimalBlueRequest { get; set; }
        public string OptimalBlueResponse { get; set; }
        public string OptimalBlueHistoryData { get; set; }
        public string RateRegistrationRegisteredBy { get; set; }
        public DateTime? RateRegistrationRegistrationDate { get; set; }
        public DateTime? RateRegistrationExpirationDate { get; set; }
        public string RateRegistrationInvestorName { get; set; }
        public string RateRegistrationReference { get; set; }
        public bool? RateRegistrationLoanIsRegistered { get; set; }
        public string RateRegistrationRegisteredUserId { get; set; }
        public decimal? TotalYearlyMi { get; set; }
        public decimal? TotalBox4 { get; set; }
        public string ClosingTaxYear { get; set; }
        public decimal? ClosingTaxYearInterestReceived { get; set; }
        public string SubTaxYear { get; set; }
        public decimal? SubTaxYearInterestReceived { get; set; }
        public decimal? SubTaxYearPointsPaid { get; set; }
        public decimal? SubTaxYearRefundOrOverpaidInterest { get; set; }
        public string BorrowerDescription4 { get; set; }
        public string BorrowerDescription5 { get; set; }
        public decimal? MIPremiums { get; set; }
        public decimal? SubTaxYearMIPremiums { get; set; }
        public decimal? OutstandingMtgPrincipal { get; set; }
        public DateTime? OutstandingMtgPrincipalDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string BorrowerDescription6 { get; set; }
        public string BorrowerDescription7 { get; set; }
        public bool? IsSameAddresswithPayer { get; set; }
        public bool? CopyFromSubjectProperty { get; set; }
        public bool? ParticipateHomePoints { get; set; }
        public string LoanTemplateFile { get; set; }
        public string LoanProgramFile { get; set; }
        public string ClosingCostProgramFile { get; set; }
        public string DocSetFile { get; set; }
        public string FormListFile { get; set; }
        public string MiscDataFile { get; set; }
        public string MaventReviewResult { get; set; }
        public string MaventOrderedBy { get; set; }
        public DateTime? MaventOrderedDate { get; set; }
        public string MaventCraxResult { get; set; }
        public string MaventEnterpriseResult { get; set; }
        public string MaventGseResult { get; set; }
        public string MaventHighCostResult { get; set; }
        public string MaventHmdaResult { get; set; }
        public string MaventLicenseResult { get; set; }
        public string MaventOfacResult { get; set; }
        public string MaventOtherResult { get; set; }
        public string MaventStateResult { get; set; }
        public string MaventTilaRorResult { get; set; }
        public string MaventTilaToleranceResult { get; set; }
        public bool? MaventAutoOrderIndicator { get; set; }
        public string MaventHpmlResult { get; set; }
        public string MaventNmlsResult { get; set; }
        public string MaventATRQMResult { get; set; }
        public string DataTracLoanId { get; set; }
        public bool? FannieDuAutoOrderIndicator { get; set; }
        public bool? FannieEcAutoOrderIndicator { get; set; }
        public bool? FreddieLPAAutoOrderIndicator { get; set; }
        public bool? FreddieLQAAutoOrderIndicator { get; set; }
        public string Id { get; set; }
    }
}