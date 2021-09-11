“Keep multiple copies of a service running in different locations, accept modifications everywhere, and disseminate all modifications among them.”

If you want to change your replication scheme such that it can continue to operate during a transient network partition, then you will have to make some compromises. Obviously, it is impossible to reach consensus without communication, so if all cluster nodes are to make progress in accepting and processing requests at all times, conflicting actions may be performed.
