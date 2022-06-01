import { IProduct } from "./product";

    export interface IPagination {
        data: IProduct[];
        pageIndex: number;
        pageSize: number;
        count: number;
        
    }


    



