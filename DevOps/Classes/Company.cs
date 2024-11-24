using DevOps.Interfaces;

public class Complany : ICompany
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public List<IWorker> Workers => throw new NotImplementedException();
    public bool FireWorkerAt(int id)
    {
        throw new NotImplementedException();
    }
    public void HireWorker(IWorker worker)
    {
        throw new NotImplementedException();
    }
}