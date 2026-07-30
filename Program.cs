using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineExercise
{
   public interface IActivity
   {
      void Execute();
   }

   public interface IWorkflow
   {
      void Add(IActivity activity);
      void Remove(IActivity activity);
      IEnumerable<IActivity> GetActivities();

   }

   public class Workflow : IWorkflow
   {
      private readonly List<IActivity> _activities;

      public Workflow()
      {
       _activities = new List<IActivity>();
      }

      public void Add(IActivity activity)
      {
         if (activity == null)
          throw new ArgumentNullException(nameof(activity));

         _activities.Add(activity);

      }

      public void Remove(IActivity activity)
      {
         _activities.Remove(activity);
      }

      public IEnumerable<IActivity> GetActivities()
      {
         return _activities;
      }
   }

   public class WorkflowEngine
   {
      public void Run(IWorkflow workflow)
      {
         if (workflow == null)
          throw new ArgumentNullException(nameof(workflow));

         foreach (var activity in workflow.GetActivities())
         {
           activity.Execute();
         }
      }
   }

   public class UploadVideo : IActivity
   {
      public void Execute()
      {
         Console.WriteLine("1. Video bulut depolama alanına yükleniyor...");
      }

   }

   public class CallVideoEncodingService : IActivity
   {
      public void Execute()
      {
         Console.WriteLine("2. Üçüncü taraf video dönüştürme (encoding) servisi çağrılıyor...");
      }

   }

   public class SendEmailNotification : IActivity
   {
      public void Execute()
      {
         Console.WriteLine("3. Video sahibine e-posta bildirimi gönderiliyor...");
      }

   }

   public class ChangeStatusToProcessing : IActivity
   {
      public void Execute()
      {
         Console.WriteLine("4. Veritabanındaki video durumu 'Processing' olarak güncelleniyor.");
      }

   }
   class Program
   {
      static void Main(string[] args)
      {

         var workflow = new Workflow();

         workflow.Add(new UploadVideo());
         workflow.Add(new CallVideoEncodingService());
         workflow.Add(new SendEmailNotification());
         workflow.Add(new ChangeStatusToProcessing());

         var engine = new WorkflowEngine();
         engine.Run(workflow);

      }

   }

}
