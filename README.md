# Orleans-Basics

An Orleans application consists of a few separate pieces, generally all as separate projects:
Grain interfaces
Grain implementations
Orleans Silo host
Orleans Client


Grains — the “virtual actors” and/or “primitives” that are described in the actor model definition above. Grains are the objects that actually contain your logic that is to be distributed. Each individual grain is guaranteed to operate in a single-threaded execution model as to greatly simplify the programming, and avoid race conditions. The grains are written in an asynchronous manner, and are intended for very fast running operations (< 200ms IIRC) — though I’m using it for operations that take MUCH longer, maybe I can do a post about that at some point if everything works!

Silos — the area where your “grains” are kept. A silo can contain many grain types, as well as many instantiations of those types, depending on your needs.

Clusters — a collection of silos. This allows for the “scale out” portion of Orleans. If more or less resources are needed, you can simply register or kill silos on your cluster. Scaling made easy!
