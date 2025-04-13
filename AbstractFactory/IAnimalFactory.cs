namespace AbstractFactory;

public interface IAnimalFactory
{
    IDog CreateDog();
    ICat CreateCat();
}