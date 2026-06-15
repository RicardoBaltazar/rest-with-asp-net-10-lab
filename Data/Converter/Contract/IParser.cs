namespace Data.Converter.Contract
{
    public interface IParser<O, D>
    {
        D Parse(O origin);

        List<O>ParseList(List<D> origin);

        O Parse(D origin);

        List<D> ParseList(List<O> origin);
    }
}