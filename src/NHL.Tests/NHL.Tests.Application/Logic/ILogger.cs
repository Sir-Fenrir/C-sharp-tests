namespace Logic;

// We need this interface in order to enable mocking.
// Interfaces are generally a good practice, but you don't always need to make an interface,
// it can really clog up your projects if you never need them!
// Besides, IDE's can really easily help you with extracting interfaces when you do need one after all.
public interface ILogger
{
    // In case of success we return true! Mostly for demonstration purposes, but depending on what you're writing to, it could fail!
    bool Log(string message);
}
