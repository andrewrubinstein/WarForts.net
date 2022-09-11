using System.Collections;
class Session {
    static private Int32 running_number = 0;
    public Int32 session_id;
    public Int32 game_id = -1;

    public Int32 start_time;
    public static Int32 valid_for_hours = 2;
    public Session()
    {
        this.session_id = running_number++;
        start_time = DateTime.Now.Hour;
    }
    bool is_valid()
    {
        return  DateTime.Now.Hour - start_time < 2;
    }
};
class SessionManager {
    Dictionary<Int32, Session> sessions;
    public SessionManager()
    {
        this.sessions = new Dictionary<Int32, Session>();
    }
    public Int32 register_session() //returns registered session id
    {
        var session = new Session();
        this.sessions[session.session_id] = session;
        return session.session_id;
    }
    public void unregister_session(Int32 id)
    {
        this.sessions.Remove(id);
    }
    public Session get_session(Int32 id)
    {
        return this.sessions[id];
    }
};