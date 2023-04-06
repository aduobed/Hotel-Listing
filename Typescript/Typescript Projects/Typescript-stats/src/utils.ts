export const dateStringToDate = (dateString: string): Date => {
    //e.g of date = 28/10/2018
    const data = dateString.split('/').map((value: string) => {
        return parseInt(value);
    });

    return new Date(data[2], data[1] - 1, data[0]);
};
