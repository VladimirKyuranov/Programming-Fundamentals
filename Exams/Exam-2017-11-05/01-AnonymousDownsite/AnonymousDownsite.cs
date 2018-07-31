using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class AnonymousDownsite
{
    static void Main(string[] args)
    {
        int affectedSitesCount = int.Parse(Console.ReadLine());
        int securityKey = int.Parse(Console.ReadLine());
        List<string> sites = new List<string>();
        decimal totalLoss = 0;
        BigInteger securityToken = 1;

        for (int power = 0; power < affectedSitesCount; power++)
        {
            securityToken *= securityKey;
        }

        for (int site = 0; site < affectedSitesCount; site++)
        {
            string[] siteStats = Console.ReadLine()
                .Split()
                .ToArray();

            string siteName = siteStats[0];
            long siteVisits = long.Parse(siteStats[1]);
            decimal pricePerVisit = decimal.Parse(siteStats[2]);

            sites.Add(siteName);
            totalLoss += siteVisits * pricePerVisit;
        }

        if (affectedSitesCount > 0)
        {
            Console.WriteLine(string.Join(Environment.NewLine, sites));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}