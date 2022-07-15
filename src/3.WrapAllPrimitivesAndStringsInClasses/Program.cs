/**
 * 
 * Aka “No Naked Primitives”
 * 
        All value types, that your programming language provides (e.g. booleans, numbers, strings), 
            need to be wrapped and must not be visible at object boundaries.
 
        Arrays, all kinds of containers like lists or hash-tables and even Object (the root class of the language’s class hierarchy) 
            are considered primitive as well.
 * 
 *      
 *      A string representing a name is an under-engineered design because many strings are no valid names. 
 *      In an object oriented system we would like to represent the concept of a name with a Name class.

        Usually Value Objects are used for this purpose. 

        Also a list of shopping items is not a shopping basket. 
        A general purposes list implementation offers operations that do not make sense for a shopping basket. 
        So containers need to be encapsulated.
 * **/


class Program
{
    static void Main(string[] args)
    {

    }

}