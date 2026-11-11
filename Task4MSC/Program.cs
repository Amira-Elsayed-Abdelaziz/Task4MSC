using static Task4MSC.LibraryData;
namespace Task4MSC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 1: Filtration (Where)

            #region 1. Get all books whose CopiesInStock is greater than 0.
            //var booksInStock = BookList.Where(b => b.CopiesInStock > 0);
            //foreach (var item in booksInStock)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Get all Programming books that are currently in stock.
            //var programmingBooksInStock = BookList.Where(b => b.CopiesInStock > 0 && b.Genre == "Programming");
            //foreach (var item in programmingBooksInStock)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Get all books whose Title starts with the letter C (use StartsWith).
            //var booksStartingWithC = BookList.Where(b => b.Title.StartsWith("C"));
            //foreach (var item in booksStartingWithC)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region Part 2: Projection (Select)

            #region 4. Print only the book titles.
            //var bookTitles = BookList.Select(b => b.Title);
            //foreach (var item in bookTitles)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Print BookId and Title using an anonymous type.
            //var bookIdAndTitle = BookList.Select(b => new { b.BookId, b.Title });
            //foreach (var item in bookIdAndTitle)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6. Print each book as "[ID] Title - Genre" using string interpolation inside Select.
            //var bookDetails = BookList.Select(b => $"[{b.BookId}] {b.Title} - {b.Genre}");
            //foreach (var item in bookDetails)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Part 3: SelectMany
            #region 7. Get all Loans of all members as one flattened sequence.
            //var allLoans = MemberList.SelectMany(m => m.Loans);
            //foreach (var item in allLoans)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 8. Get the loans of only certain members (filter members with Where first, then SelectMany).
            //var certainMembersLoans = MemberList.Where(m =>  m.Id==0).SelectMany(m => m.Loans);
            //foreach (var item in certainMembersLoans)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #endregion
        }
    }
}
