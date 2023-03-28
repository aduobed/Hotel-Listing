interface Sortable {
    length: number;
    compare(leftIndex: number, rightIndex: number): boolean;
    swap(leftIndex: number, rightIndex: number): void;
}

export class Sorter {
    constructor(public collection: Sortable) {}

    sort(): void {
        const { length } = this.collection;

        let isSorted = false;
        while (!isSorted) {
            isSorted = true;
            for (let i = 0; i < length - 1; i++) {
                if (this.collection.compare(i, i + 1)) {
                    this.collection.swap(i, i + 1);
                    isSorted = false;
                }
            }
        }
    }
}
