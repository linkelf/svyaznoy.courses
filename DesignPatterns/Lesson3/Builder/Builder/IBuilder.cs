namespace Builder
{
    public interface IBuilder
    {
        IBuilder SetPrice(decimal price);
        IBuilder SetName(string name);
        IBuilder SetArticle(string articel);
        IBuilder SetWeight(decimal weight);
        ProductLabel GetResult();

        IPriceSetter StartStrictInit();
    }

    public interface IPriceSetter
    {
        INameSetter SetPrice(decimal price);
    }

    public interface INameSetter
    {
        ProductLabel SetName(string name);
    }
}