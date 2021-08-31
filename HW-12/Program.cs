using System;

namespace HW_12
{
    //enum License
    //{
    //    pro,
    //    exp,
    //    notSet
    //}
    class Program
    {
        //private const string pro = "222", exp = "111";
        private const int pro = 222, exp = 111;

        static void Main(string[] args)
        {
            //DocumentWorker d = null;
            /// License license = License.notSet;
            Console.WriteLine("Введите ключ");
            //var res = Console.ReadLine();
            _ = int.TryParse(Console.ReadLine(), out var res);
            //v---1
            //switch (res)
            //{
            //    case pro:
            //        license = License.pro;
            //        break;
            //    case exp:
            //        license = License.exp;
            //        break;
            //    case "":
            //       license = License.notSet;
            //        break;
            //}


            //switch (license)
            //{
            //    case License.pro:
            //        d = new ProDocementWorker();
            //        break;
            //    case License.exp:
            //        d = new ExpertDocumentWorker();
            //        break;
            //    default:
            //        d = new DocumentWorker();
            //        break;
            //}
            // ---v2
            DocumentWorker d = res switch
            {
                pro => new ProDocementWorker(),
                exp => new ExpertDocumentWorker(),
                _ => new DocumentWorker(),
            };

            d.Show();
            //switch (res)
            //{
            //    case pro:
            //        d = new ProDocementWorker();
            //        break;
            //    case exp:
            //        d = new ExpertDocumentWorker();
            //        break;
            //    default:
            //        d = new DocumentWorker();
            //        break;
            //}                    
        }
        // d.Show();
    }
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Рекдактирование документа доступно в версии Про");
        }
        public virtual void SaveDocement()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }

        public virtual void Show()
        {
            OpenDocument();
            EditDocument();
            SaveDocement();
        }

    }
    class ProDocementWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }

        public override void Show()
        {
            OpenDocument();
            EditDocument();
            //SaveDocement();
        }
    }
    class ExpertDocumentWorker : ProDocementWorker
    {
        public override void SaveDocement() => Console.WriteLine("Документ сохранен в новом формате");
        public override void Show()
        {
            SaveDocement();
        }

    }
}
