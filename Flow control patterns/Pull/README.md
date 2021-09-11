“Have the consumer ask the producer for batches of data.”

One challenge in Reactive systems is how to balance the relationship between producers and consumers of messages—be they requests that need processing or facts on their way to persistent storage. The difficulty lies in the dynamic nature of the problems that may arise from incorrect implementations: only under realistic input load can you observe whether a fast producer might overwhelm a resource-constrained consumer. Often, your load test environments are based on business forecasts that may be exceeded in real usage.

The formulation of the Pull pattern presented here is the result of Roland’s involvement in the Reactive Streams initiative,  where the resulting behavior is also characterized as dynamic push-pull, an aspect that we will discuss later.
