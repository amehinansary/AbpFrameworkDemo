import type { BookType } from './books/book-type.enum';

export interface CreateUpdateBookDto {
  authorId?: string;
  name: string;
  type: BookType;
  publishDate: string;
  price: number;
}
