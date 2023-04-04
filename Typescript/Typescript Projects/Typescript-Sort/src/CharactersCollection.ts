import { Sorter } from './Sorter';

export class CharactersCollection extends Sorter {
    constructor(public data: string) {
        super();
    }

    get length() {
        return this.data.length;
    }

    compare(leftIndex: number, rightIndex: number): boolean {
        return (
            this.data[leftIndex].toLowerCase() >
            this.data[rightIndex].toLowerCase()
        );
    }

    swap(leftIndex: number, rightIndex: number): void {
        let characters = this.data.split('');

        [characters[leftIndex], characters[rightIndex]] = [
            characters[rightIndex],
            characters[leftIndex],
        ];
        this.data = characters.join('');
    }
}
