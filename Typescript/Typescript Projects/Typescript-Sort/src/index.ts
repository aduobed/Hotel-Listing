import { Sorter } from './Sorter';
import { NumbersCollection } from './NumbersCollection';
import { CharactersCollection } from './CharactersCollection';

// const collection = new NumbersCollection([10, 2, -4]);
// const sorter = new Sorter(collection);
// sorter.sort();
// console.log(collection.data);
//
const characters = new CharactersCollection('ayBc');
const sorter = new Sorter(characters);
sorter.sort();
console.log(characters.data);
