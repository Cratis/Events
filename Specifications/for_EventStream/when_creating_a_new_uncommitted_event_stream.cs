using Cratis.Events.Specs.behaviors;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_creating_a_new_uncommitted_event_stream : given.an_empty_uncommitted_event_stream
    {
#pragma warning disable 0169        
        Behaves_like<an_empty_event_stream> an_event_stream;
#pragma warning restore 0169        
    }
}