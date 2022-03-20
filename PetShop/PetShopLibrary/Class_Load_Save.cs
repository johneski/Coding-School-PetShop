using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public interface ISave
    {
        
        public void DoSave();
    }
    public class SavePet : ISave
    { 
        public SavePet()
        {

        }
        public void DoSave()
        {

        }
    }
    public class SaveTransaction : ISave
    {
        public SaveTransaction()
        {

        }
        public void DoSave()
        {

        }
    }

    public interface ICreate
    {
        public void DoCreate();
    }
    public class CreatePet : ICreate
    {
        public CreatePet()
        {

        }
        public void DoCreate()
        {

        }
    }
    public class CreateTransaction : ICreate
    {
        public CreateTransaction()
        {

        }
        public void DoCreate()
        {

        }
    }

    public interface ILoad
    {
        public void DoLoad();
    }
    public class LoadPet : ILoad
    {
        public LoadPet()
        {

        }
        public void DoLoad()
        {

        }
    }
    public class LoadTransaction : ILoad
    {
        public LoadTransaction()
        {

        }
        public void DoLoad()
        {

        }
    }
    public class Manager <T>
    {
        
        public Manager(ISave save=null,ILoad load=null,ICreate create=null)
        {
            List<T> list = new List<T>();

        }
        public void DoLoad()
        {

        }
        public void DoSave()
        {

        }


        Manager<T> _manager = new Manager<T>(new SavePet(), new LoadTransaction(),new CreatePet());
    }

    

   
}
