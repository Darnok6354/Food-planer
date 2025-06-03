using Supabase;

using System.Threading.Tasks;

 

public class SupabaseService

{

    private Supabase.Client _client;

 

    public SupabaseService()

    {

        var url = "https://izothuxchvuyafljdgsk.supabase.co"; // <- Zmień na swój URL

        var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Iml6b3RodXhjaHZ1eWFmbGpkZ3NrIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc0ODk2NTcwNywiZXhwIjoyMDY0NTQxNzA3fQ.SSZ8NXxYgUuREMaxRw-rIRSDsjHvp7mWHn-qX7lPtv8";     // <- Zmień na swój anon key

 

        var options = new Supabase.SupabaseOptions

        {

            AutoConnectRealtime = false

        };

 

        _client = new Supabase.Client(url, key, options);

    }

 

    public async Task InitializeAsync()

    {

        await _client.InitializeAsync();

    }

 

    public Supabase.Client Client => _client;

}