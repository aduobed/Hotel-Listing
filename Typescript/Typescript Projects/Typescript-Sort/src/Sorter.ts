export abstract class Sorter {
    abstract compare(leftIndex: number, rightIndex: number): boolean;
    abstract swap(leftIndex: number, rightIndex: number): void;
    abstract length: number;

    sort(): void {
        const { length } = this;

        let isSorted = false;
        while (!isSorted) {
            isSorted = true;
            for (let i = 0; i < length - 1; i++) {
                if (this.compare(i, i + 1)) {
                    this.swap(i, i + 1);
                    isSorted = false;
                }
            }
        }
    }
}
