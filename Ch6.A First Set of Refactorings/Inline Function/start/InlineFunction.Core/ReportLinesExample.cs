using System.Collections.Generic;

namespace InlineFunction.Core
{
    public class ReportLinesExample
    {
        public static List<ProductLine> ReportLines(Product product)
        {
            List<ProductLine> lines = new List<ProductLine>();
            GatherProductData(lines, product);

            return lines;
        }

        private static void GatherProductData(List<ProductLine> lines, Product product)
        {
            lines.Add(new ProductLine()
            {
                Key = "name",
                Value = product.Name
            });

            lines.Add(new ProductLine()
            {
                Key = "vendor",
                Value = product.Vendor
            });
        }
    }
}
