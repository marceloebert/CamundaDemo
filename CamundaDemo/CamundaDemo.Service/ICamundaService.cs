using CamundaDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CamundaDemo.Service
{
    public interface ICamundaService
    {
        Task StartProcess(string processKey, Process process);

        Task<List<ExternalTask>> GetExternalTasks();

        Task CompleteExternalTask(string id, CompleteExternalTaskRequest request);
    }
}
