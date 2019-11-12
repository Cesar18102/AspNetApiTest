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

        public bool LogOut(UserSession session)
        {
            if (!IsActive(session))
                return false;

            Sessions.RemoveAll(S => S.id == session.id);
            return true;
        }

        public bool IsActive(UserSession session) => Sessions.Exists(S => S.id == session.id && S.hash == session.hash);
    }
}