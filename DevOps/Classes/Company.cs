namespace DevOps.Classes;

using DevOps.Interfaces;

public class Company : ICompany
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<IWorker> Workers { get; } = new List<IWorker>();

    public void HireWorker(IWorker worker)
    {
        if (worker != null && !Workers.Contains(worker))
        {
            Workers.Add(worker);
        }
    }

    public bool FireWorkerAt(Guid id)
    {
        var worker = Workers.FirstOrDefault(w => w.Id == id);
        if (worker != null)
        {
            _ = Workers.Remove(worker);
            return true;
        }
        return false;
    }
}
