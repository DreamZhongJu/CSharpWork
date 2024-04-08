using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验
{
    public interface IProductionFactory
    {
        void DuckNeck();
        void DuckWing();
    }

    public class WuhanFactory : IProductionFactory
    {
        public void DuckNeck()
        {
            Console.WriteLine("武汉工厂生成鸭脖");
        }

        public void DuckWing()
        {
            Console.WriteLine("武汉工厂生产鸭翅");
        }
    }

    public class NanjingFactory : IProductionFactory
    {
        public void DuckNeck()
        {
            throw new NotSupportedException("南京工厂不生产鸭脖");
        }

        public void DuckWing()
        {
            Console.WriteLine("南京工厂生产鸭翅");
        }
    }

    public class ChangshaFactory : IProductionFactory
    {
        public void DuckNeck()
        {
            Console.WriteLine("长沙工厂生产鸭脖");
        }

        public void DuckWing()
        {
            throw new NotSupportedException("长沙工厂不生产鸭翅");
        }
    }

    public delegate void ProductionDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            IProductionFactory wuhanFactory = new WuhanFactory();
            IProductionFactory nanjingFactory = new NanjingFactory();
            IProductionFactory changshaFactory = new ChangshaFactory();

            ProductionDelegate productionDelegate = null;

            productionDelegate += wuhanFactory.DuckNeck;

            productionDelegate += wuhanFactory.DuckWing;

            productionDelegate += nanjingFactory.DuckWing;

            productionDelegate += changshaFactory.DuckNeck;
            productionDelegate();

            ProductionDelegate  produce= null;
            produce += nanjingFactory.DuckNeck;
            produce();
        }
    }
}
