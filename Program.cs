using System.Collections.Immutable;
using System.IO;

namespace Jack_sHouseHomeWork
{
    public class Program
    {
        public static void Main()
        {
            Part part1 = new MyPart1();
            Part part2 = new MyPart2();
            Part part3 = new MyPart3();
            Part part4 = new MyPart4();
            Part part5 = new MyPart5();
            Part part6 = new MyPart6();
            Part part7 = new MyPart7();
            Part part8 = new MyPart8();
            Part part9 = new MyPart9();

            var list = ImmutableList<string>.Empty;
            part1.AddPart(list);
            part2.AddPart(part1.Poem);
            part3.AddPart(part2.Poem);
            part4.AddPart(part3.Poem);
            part5.AddPart(part4.Poem);
            part6.AddPart(part5.Poem);
            part7.AddPart(part6.Poem);
            part8.AddPart(part7.Poem);
            part9.AddPart(part8.Poem);

            Console.WriteLine("Строфа 1:");
            Console.WriteLine(string.Join(Environment.NewLine, part1.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 2:");
            Console.WriteLine(string.Join(Environment.NewLine, part2.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 3:");
            Console.WriteLine(string.Join(Environment.NewLine, part3.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 4:");
            Console.WriteLine(string.Join(Environment.NewLine, part4.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 5:");
            Console.WriteLine(string.Join(Environment.NewLine, part5.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 6:");
            Console.WriteLine(string.Join(Environment.NewLine, part6.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 7:");
            Console.WriteLine(string.Join(Environment.NewLine, part7.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 8:");
            Console.WriteLine(string.Join(Environment.NewLine, part8.Poem));
            Console.WriteLine();

            Console.WriteLine("Строфа 9:");
            Console.WriteLine(string.Join(Environment.NewLine, part9.Poem));
        }
    }

    public class MyPart9 : Part
    {
        public override string SelfPart =>
            "Вот два петуха,\r\nКоторые будят того пастуха,\r\nКоторый бранится с коровницей строгою,\r\nКоторая доит корову безрогую,\r\nЛягнувшую старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart8 : Part
    {
        public override string SelfPart =>
            "А это ленивый и толстый пастух,\r\nКоторый бранится с коровницей строгою,\r\nКоторая доит корову безрогую,\r\nЛягнувшую старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart7 : Part
    {
        public override string SelfPart => "А это старушка, седая и строгая,\r\nКоторая доит корову безрогую,\r\nЛягнувшую старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart6 : Part
    {
        public override string SelfPart => "А это корова безрогая,\r\nЛягнувшая старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart5 : Part
    {
        public override string SelfPart => "Вот пес без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart4 : Part
    {
        public override string SelfPart =>
            "Вот кот,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart3 : Part
    {
        public override string SelfPart => "А это веселая птица-синица,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart2 : Part
    {
        public override string SelfPart => "А это пшеница,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
    }

    public class MyPart1 : Part
    {
        public override string SelfPart => "Вот дом,\r\nКоторый построил Джек.";
    }

    public abstract class Part
    {
        public virtual void AddPart(ImmutableList<string> collection)
        {
            Poem = collection.Add(SelfPart);
        }

        public ImmutableList<string> Poem { get; set; }
        public abstract string SelfPart { get; }
    }
}