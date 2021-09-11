“Throttle your own output rate according to contracts with other services.”

We have discussed how each component can mediate, measure, and react to back pressure in order to avoid uncontrollable overload situations. With these means at your disposal, it is not just fair but obligatory that you respect the ingestion limits of other components. In situations where you outpace consumers of your outputs, you can slow to match their rate, and you can even ensure that you do not violate a prearranged rate agreement.

In the Circuit Breaker pattern, you saw that a circuit breaker can be designed such that it rejects requests that would otherwise lead to a request rate that is too high. With the Pull pattern, you can turn this around and not generate requests more quickly than they are allowed to be sent.
