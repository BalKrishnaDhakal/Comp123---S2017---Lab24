using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: This is an Interface that defines a Karma Property that 
 * must be implemente in any class that subscribe to it 
 * Version: 0.1 - Created IHasKarma Interface
 */
namespace Comp123___S2017___Lab24
{
    /// <summary>
    ///  This is the IHasKarma Interface
    /// </summary>
    public interface IHasKarma
    {
        // PUBLIC PROPERTY
        int Karma { get; set; }
    }
}