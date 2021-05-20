using System;
using System.Collections.Generic;
using CalenderPlanner.Domain.Interfaces;
using CalenderPlanner.Domain.Models;

namespace CalenderPlanner.Storing.Repos
{
  public class EventRepo : IRepo<Event>
  {
    private readonly CPContext _context;

    public EventRepo(CPContext context)
    {
      _context = context;
    }

    public IEnumerable<Event> Create(Func<Event, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public bool Read(Event entry)
    {
      _context.Events.Add(entry);
      return true;
    }

    public Event Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}