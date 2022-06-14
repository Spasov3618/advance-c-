using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            Portfolio = new List<Stock>();
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }

        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count => Portfolio.Count;

        public void BuyStock(Stock stock)

        {
            if (stock.MarketCapitalization >= 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
            //Method void BuyStock(Стокова наличност) – добавете единен запас от дадената компания, ако пазарната капитализация на акциите е по-голяма от $10000 и инвеститорът има достатъчно пари.След това намалете MoneyToИнвест с цената на запаса. Ако даден запас не може да бъде купен методът не трябва да прави нищо.
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock find = Portfolio.FirstOrDefault(x => x.CompanyName == companyName);
            if (find == null)
            {
                return $"{companyName} does not exist.";
            }
            else if (sellPrice <= find.PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }
            else
            {
                MoneyToInvest+= sellPrice;
                Portfolio.Remove(find);
                return $"{companyName} was sold.";
            }

        }
        public Stock FindStock(string companyName)
        {
            var find = Portfolio.FirstOrDefault(x => x.CompanyName == companyName);
            if (find != null)
            {
                return find;
            }
            return null;
        }
       public Stock FindBiggestCompany()
        {
            decimal capi = Portfolio.Max(x => x.MarketCapitalization);
            Stock find = Portfolio.FirstOrDefault(x => x.MarketCapitalization == capi);
            if (find != null)
            {
                return find;

            }
            return null;
        }
        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var item in Portfolio)
            {
                sb.AppendLine($"Company: {item. CompanyName}");
                sb.AppendLine($"Director: {item. Director}");
                sb.AppendLine($"Price per share: ${item. PricePerShare}");
                sb.AppendLine($"Market capitalization: ${item. MarketCapitalization}");
            }
            return sb.ToString().TrimEnd();
        }
    }   
}
