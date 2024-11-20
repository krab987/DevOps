namespace DevOps.Interfaces;
/// <summary>
/// Company that has Name Description and workers \ can hire and fire `em
/// </summary>
public interface ICompany
{
    string Name { get; set; }
    string Description { get; set; } //Description like what this company is doing?
    
    List<IWorker> Workers { get; }

    /// <summary>
    /// Hire worker to company
    /// </summary>
    /// <param name="worker">Worker to hire</param>
    void HireWorker(IWorker worker);

    /// <summary>
    /// Fire worker (remove) from company
    /// </summary>
    /// <param name="id">Id of worker to fire</param>
    bool FireWorkerAt(int id);


}