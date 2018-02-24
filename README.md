# TrimSupport
 A simple C# class that helps trim items before saving them to the database
 
 ## Deployment

I think every one of us hates when data from the "     John    " or "Anna               " variety is recorded in a database. You can call Trim.TrimSupport() and make a vow before calling dbSet.Add(), dbSet.Update(), dbSet.Attach(), or dbSet.AddRange() and others where dbSet is your DbContext. The method uses reflection and will take care of the class you are submitting and will take all the properties that are System.String and will do Trim on them and if String.Empty is submitted it will make it null.
 
 ## Built With

* [.NET Framework 4.6.2](https://www.microsoft.com/en-us/download/details.aspx?id=53344) - The web framework used
 
## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details

