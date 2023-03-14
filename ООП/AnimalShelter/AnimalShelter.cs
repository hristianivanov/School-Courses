namespace AnimalShelter
{
    using System.Linq;
    using System.Collections;
    public class AnimalShelter<T> : IEnumerable<T>
    {
        private const int DEFAULT_PLACES_COUNT = 20;
        private T[] animalList;
        private int usedPlaces = 0;

        public AnimalShelter(int animalsCnt)
        {
            animalList = new T[animalsCnt];
        }
        public AnimalShelter()
            : this(DEFAULT_PLACES_COUNT)
        {

        }

        public void Shelter(T newAnimal)
        {
            if (animalList.Length == usedPlaces)
                throw new ArgumentException("Shelter is full");
            animalList[usedPlaces++] = newAnimal;
        }

        public T Release(int index)
        {
            if(index<0 || index == animalList.Length)
                throw new ArgumentException("Invalid cell index");
            T searchedAnimal = animalList[index];
            animalList[index] = default(T);
            usedPlaces--;
            animalList = animalList
                .Where(x => x != null)
                .ToArray();
            return searchedAnimal;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < animalList.Length; i++)
                yield return animalList[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
