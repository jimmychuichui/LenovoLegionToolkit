﻿using System;
using System.Threading.Tasks;
using LenovoLegionToolkit.Lib.Controllers;

namespace LenovoLegionToolkit.Lib.Automation.Steps;

public class OverclockDiscreteGPUAutomationStep : IAutomationStep<OverclockDiscreteGPUAutomationStepState>
{
    private readonly GPUOverclockController _controller = IoCContainer.Resolve<GPUOverclockController>();

    public OverclockDiscreteGPUAutomationStepState State { get; }

    public OverclockDiscreteGPUAutomationStep(OverclockDiscreteGPUAutomationStepState state) => State = state;

    public Task<OverclockDiscreteGPUAutomationStepState[]> GetAllStatesAsync() => Task.FromResult(Enum.GetValues<OverclockDiscreteGPUAutomationStepState>());

    public Task<bool> IsSupportedAsync() => _controller.IsSupportedAsync();

    public async Task RunAsync(AutomationEnvironment _)
    {
        if (!await _controller.IsSupportedAsync().ConfigureAwait(false))
            return;

        var (_, info) = _controller.GetState();

        switch (State)
        {
            case OverclockDiscreteGPUAutomationStepState.On:
                _controller.SaveState(true, info);
                break;
            case OverclockDiscreteGPUAutomationStepState.Off:
                _controller.SaveState(false, info);
                break;
        }

        await _controller.ApplyStateAsync(true).ConfigureAwait(false);
    }

    IAutomationStep IAutomationStep.DeepCopy() => new OverclockDiscreteGPUAutomationStep(State);
}
