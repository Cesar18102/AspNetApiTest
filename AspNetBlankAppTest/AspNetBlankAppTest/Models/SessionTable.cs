using System.Collections.Generic;

namespace AspNetBlankAppTest.Models
{
    public class SessionTable
    {
        private List<UserSession> Sessions = new List<UserSession>();

        public void LogIn(UserSession session)
        {
            Sessions.RemoveAll(S => S.id == session.id);
            Sessions.Add(session);
        }

        public void LogOut(UserSession session)
        {
            if (IsActive(session))
                Sessions.RemoveAll(S => S.id == session.id);
        }

        public bool IsActive(UserSession session) => Sessions.Exists(S => S.id == session.id && S.hash == session.hash);

        public List<UserSession> GetSessions() => Sessions;//remove
    }
}