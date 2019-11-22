This code is provided without warranty of any kind. 

Really, it's sample code. 

This project is intended to allow very simple profiling sessions.

** The main exercise

1. Open the project and build, just to see it works
2. Check that the count on line 18 in Program.cs is 30,000
3. Use Debug/Performance Profiler, select CPU Usage, and hit start
4. When the data is ready explore
   a) the intial window
   b) the "detail" which is a link a bit right and above the middle
   c) in the detail view, first look at the call tree and hot path (my favorite)
   d) also explore the caller/callee as a way to move through code, generally hot path
5. There is a single line of code that causes the majority of the performance issue. Can you find it?

As an aside, do you know why this is a problem? Can you fix it?

** Alternate exercise - another perf problem

Now, when you rerun things are awfully fast for this method of profiling. 
A few hundred samples just isn't enough. You could increase sampling rate, but
I suggest you just up the count in Program.cs to 100,000.

What is the slow step now? It is not as easy to fix, but how would you fix it?

** Alternate exercise - memory problem

You can see GC in the Diagnostic pane during debugging. Set breakpoints to see 
this window. This application is designed to be bad. Feel free to fix it. 

For a deeper look at memory usage, go back to the Performance Profiler and 
do an allocation evaluation. Again, look for the call tree and the hot path. 

As you compare this data to the source code it should make sense.