/*  Copyright (C) 2008-2015 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using System.IO;
using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   partial class DirectoryInfo
   {
      #region AlphaFS

      /// <summary>[AlphaFS] Deletes empty subdirectories from the <see cref="DirectoryInfo"/> instance.</summary>
      [SecurityCritical]
      public void DeleteEmptySubdirectories()
      {
         Directory.DeleteEmptySubdirectoriesCore(null, Transaction, LongFullName, false, false, true, PathFormat.LongFullPath);
      }

      /// <summary>[AlphaFS] Deletes empty subdirectories from the <see cref="DirectoryInfo"/> instance.</summary>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      [SecurityCritical]
      public void DeleteEmptySubdirectories(bool recursive)
      {
         Directory.DeleteEmptySubdirectoriesCore(null, Transaction, LongFullName, recursive, false, true, PathFormat.LongFullPath);
      }

      /// <summary>[AlphaFS] Deletes empty subdirectories from the <see cref="DirectoryInfo"/> instance.</summary>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      /// <param name="ignoreReadOnly"><see langword="true"/> overrides read only <see cref="FileAttributes"/> of empty directories.</param>
      [SecurityCritical]
      public void DeleteEmptySubdirectories(bool recursive, bool ignoreReadOnly)
      {
         Directory.DeleteEmptySubdirectoriesCore(null, Transaction, LongFullName, recursive, ignoreReadOnly, true, PathFormat.LongFullPath);
      }

      #endregion // AlphaFS
   }
}
