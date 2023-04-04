import { Sorter } from './Sorter';
import { NumbersCollection } from './NumbersCollection';
import { CharactersCollection } from './CharactersCollection';
import { LinkedList } from './LinkedList';

//Test for numbers sort
// const numbersCollection = new NumbersCollection([10, 2, -4, -8]);
// numbersCollection.sort();
// console.log(numbersCollection.data);

// Test for characters sort
// const characters = new CharactersCollection('ayBcA');
// characters.sort();
// console.log(characters.data);

//Test for linkedList sort
const linkedList = new LinkedList();
linkedList.add(500);
linkedList.add(-10);
linkedList.add(-3);

linkedList.sort();
linkedList.print();
