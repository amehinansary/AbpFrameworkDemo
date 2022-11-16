import type { AuditedEntityDto } from '@abp/ng.core';
import type { BookType } from '../book-type.enum';

export interface BookDto extends AuditedEntityDto<string> {
  authorId?: string;
  authorName?: string;
  name?: string;
  type: BookType;
  publishDate?: string;
  price: number;
}
